-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (ratio, state, weight, score, count) VALUES (87.68, 'stable', 42.17, 6.87, 92);
INSERT INTO layout_items (ratio, state, weight, score, count) VALUES (94.31, 'primary', 56.14, 54.67, 87);
INSERT INTO layout_items (ratio, state, weight, score, count) VALUES (77.56, 'edge', 62.05, 1.68, 66);
