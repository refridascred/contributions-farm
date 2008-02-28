-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, rank, ratio, score) VALUES ('standard', 56, 92.91, 86.39);
INSERT INTO layout_items (token, rank, ratio, score) VALUES ('local', 99, 15.57, 98.14);
INSERT INTO layout_items (token, rank, ratio, score) VALUES ('staging', 33, 44.87, 84.32);
