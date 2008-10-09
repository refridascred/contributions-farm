-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, token, region) VALUES (56, 'strict', 'stable');
INSERT INTO layout_items (level, token, region) VALUES (74, 'staging', 'staging');
