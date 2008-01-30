-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, region, token, level) VALUES ('blue', 'staging', 'open', 56);
INSERT INTO layout_items (label, region, token, level) VALUES ('green', 'standard', 'latest', 83);
INSERT INTO layout_items (label, region, token, level) VALUES ('strict', 'eu-west', 'fallback', 64);
