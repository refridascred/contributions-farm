-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (owner, region, level) VALUES ('strict', 'edge', 67);
INSERT INTO layout_items (owner, region, level) VALUES ('primary', 'local', 92);
INSERT INTO layout_items (owner, region, level) VALUES ('green', 'eu-west', 20);
