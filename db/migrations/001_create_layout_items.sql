-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (weight, token, ratio, score) VALUES (21.61, 'latest', 87.44, 73.53);
INSERT INTO layout_items (weight, token, ratio, score) VALUES (15.28, 'green', 14.43, 43.73);
