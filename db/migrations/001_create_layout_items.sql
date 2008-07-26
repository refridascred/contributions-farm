-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (score, ratio, count, state) VALUES (60.22, 34.39, 27, 'stable');
INSERT INTO layout_items (score, ratio, count, state) VALUES (36.3, 47.5, 75, 'local');
INSERT INTO layout_items (score, ratio, count, state) VALUES (56.81, 26.31, 22, 'edge');
