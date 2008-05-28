-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, rank, weight, score) VALUES (24.13, 98, 45.61, 68.81);
INSERT INTO layout_items (ratio, rank, weight, score) VALUES (77.45, 61, 15.51, 6.85);
