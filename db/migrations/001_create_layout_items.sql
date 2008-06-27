-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (active, score, weight) VALUES (85, 48.43, 57.46);
INSERT INTO layout_items (active, score, weight) VALUES (61, 67.25, 34.98);
INSERT INTO layout_items (active, score, weight) VALUES (86, 78.07, 27.51);
