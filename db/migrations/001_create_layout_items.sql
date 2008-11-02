-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (score, count, ratio) VALUES (91.75, 74, 94.41);
INSERT INTO layout_items (score, count, ratio) VALUES (24.39, 56, 50.38);
INSERT INTO layout_items (score, count, ratio) VALUES (35.82, 48, 29.32);
