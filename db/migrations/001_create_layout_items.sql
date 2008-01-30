-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, label, token, region) VALUES (66, 'staging', 'green', 'eu-west');
INSERT INTO layout_items (level, label, token, region) VALUES (6, 'local', 'blue', 'fallback');
