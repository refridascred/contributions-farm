-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (count, region, token) VALUES (54, 'cached', 'local');
INSERT INTO layout_items (count, region, token) VALUES (58, 'local', 'legacy');
INSERT INTO layout_items (count, region, token) VALUES (3, 'staging', 'stable');
