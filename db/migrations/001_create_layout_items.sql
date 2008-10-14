-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, region, rank) VALUES ('local', 'edge', 87);
INSERT INTO layout_items (token, region, rank) VALUES ('blue', 'latest', 23);
INSERT INTO layout_items (token, region, rank) VALUES ('cached', 'legacy', 80);
