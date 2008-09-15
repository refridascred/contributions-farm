-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (label, region, owner) VALUES ('fallback', 'latest', 'cached');
INSERT INTO layout_items (label, region, owner) VALUES ('legacy', 'eu-west', 'open');
INSERT INTO layout_items (label, region, owner) VALUES ('eu-west', 'green', 'open');
