-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (score, count, level, weight, state) VALUES (14.17, 88, 17, 68.22, 'green');
INSERT INTO layout_items (score, count, level, weight, state) VALUES (95.66, 70, 80, 65.12, 'staging');
INSERT INTO layout_items (score, count, level, weight, state) VALUES (31.95, 56, 78, 0.86, 'stable');
