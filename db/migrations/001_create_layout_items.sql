-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (score, ratio, weight, token) VALUES (4.18, 93.21, 24.85, 'green');
INSERT INTO layout_items (score, ratio, weight, token) VALUES (93.41, 7.96, 69.45, 'latest');
