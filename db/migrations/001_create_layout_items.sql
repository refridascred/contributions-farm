-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (level, region) VALUES (62, 'standard');
INSERT INTO layout_items (level, region) VALUES (25, 'staging');
INSERT INTO layout_items (level, region) VALUES (59, 'edge');
