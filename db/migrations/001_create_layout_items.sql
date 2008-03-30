-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, score, ratio, level) VALUES (73, 65.15, 87.83, 16);
INSERT INTO layout_items (rank, score, ratio, level) VALUES (95, 93.29, 96.8, 39);
INSERT INTO layout_items (rank, score, ratio, level) VALUES (18, 68.52, 32.9, 56);
