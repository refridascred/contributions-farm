-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (level, token, region) VALUES (89, 'standard', 'latest');
INSERT INTO layout_items (level, token, region) VALUES (53, 'staging', 'cached');
