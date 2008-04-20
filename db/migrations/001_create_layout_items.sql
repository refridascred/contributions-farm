-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (count, region, token) VALUES (83, 'fallback', 'standard');
INSERT INTO layout_items (count, region, token) VALUES (33, 'standard', 'open');
INSERT INTO layout_items (count, region, token) VALUES (31, 'open', 'eu-west');
