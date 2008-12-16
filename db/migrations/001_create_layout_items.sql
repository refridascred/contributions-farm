-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (score, ratio, owner) VALUES (47.21, 41.27, 'cached');
INSERT INTO layout_items (score, ratio, owner) VALUES (47.47, 74.26, 'cached');
INSERT INTO layout_items (score, ratio, owner) VALUES (64.11, 3.81, 'eu-west');
