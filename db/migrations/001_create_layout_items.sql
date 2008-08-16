-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (score, region, count, token) VALUES (89.59, 'latest', 40, 'strict');
INSERT INTO layout_items (score, region, count, token) VALUES (68.64, 'latest', 73, 'standard');
INSERT INTO layout_items (score, region, count, token) VALUES (43.65, 'eu-west', 4, 'primary');
