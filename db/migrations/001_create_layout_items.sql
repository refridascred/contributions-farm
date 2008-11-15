-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, rank, score, active) VALUES (80, 18, 62.32, 9);
INSERT INTO layout_items (count, rank, score, active) VALUES (38, 56, 68.93, 23);
INSERT INTO layout_items (count, rank, score, active) VALUES (89, 90, 54.64, 32);
