-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, state, score, ratio, weight) VALUES (37, 'strict', 2.35, 52.58, 83.94);
INSERT INTO layout_items (count, state, score, ratio, weight) VALUES (52, 'fallback', 55.37, 52.52, 86.9);
