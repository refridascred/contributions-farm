-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, score, token, ratio, level) VALUES (36, 10.47, 'open', 9.19, 95);
INSERT INTO layout_items (rank, score, token, ratio, level) VALUES (85, 94.82, 'primary', 14.14, 44);
INSERT INTO layout_items (rank, score, token, ratio, level) VALUES (56, 58.5, 'standard', 91.81, 98);
