-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, ratio, state) VALUES (89.15, 51.39, 'blue');
INSERT INTO layout_items (score, ratio, state) VALUES (89.55, 22.03, 'open');
INSERT INTO layout_items (score, ratio, state) VALUES (48.46, 77.17, 'standard');
