-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, count, region) VALUES ('cached', 6, 'primary');
INSERT INTO layout_items (token, count, region) VALUES ('primary', 16, 'legacy');
INSERT INTO layout_items (token, count, region) VALUES ('blue', 21, 'eu-west');
