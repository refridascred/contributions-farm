-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, score, active) VALUES (57.21, 98.75, 61);
INSERT INTO layout_items (ratio, score, active) VALUES (54.46, 26.49, 82);
INSERT INTO layout_items (ratio, score, active) VALUES (85.14, 62.25, 19);
