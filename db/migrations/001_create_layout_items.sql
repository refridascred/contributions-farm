-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, rank, ratio, token) VALUES (30, 15, 84.49, 'eu-west');
INSERT INTO layout_items (count, rank, ratio, token) VALUES (16, 86, 91.89, 'cached');
