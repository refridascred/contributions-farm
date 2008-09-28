-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, token, label) VALUES ('blue', 'cached', 'standard');
INSERT INTO layout_items (region, token, label) VALUES ('standard', 'eu-west', 'latest');
