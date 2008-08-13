-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, region, level) VALUES ('green', 'cached', 85);
INSERT INTO layout_items (token, region, level) VALUES ('strict', 'eu-west', 0);
INSERT INTO layout_items (token, region, level) VALUES ('latest', 'eu-west', 89);
