-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, state, count, ratio, weight) VALUES (36.58, 'green', 91, 61.65, 0.19);
INSERT INTO layout_items (score, state, count, ratio, weight) VALUES (6.14, 'open', 1, 88.16, 23.59);
INSERT INTO layout_items (score, state, count, ratio, weight) VALUES (46.62, 'strict', 19, 76.93, 29.14);
