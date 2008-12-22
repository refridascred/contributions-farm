-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, ratio, score, count) VALUES ('standard', 23.6, 41.91, 75);
INSERT INTO layout_items (token, ratio, score, count) VALUES ('edge', 14.1, 72.07, 2);
INSERT INTO layout_items (token, ratio, score, count) VALUES ('latest', 72.0, 49.25, 52);
