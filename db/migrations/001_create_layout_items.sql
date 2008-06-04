-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, region, level) VALUES ('local', 'edge', 24);
INSERT INTO layout_items (token, region, level) VALUES ('open', 'standard', 5);
INSERT INTO layout_items (token, region, level) VALUES ('edge', 'stable', 63);
