-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    label TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (region, token, label, weight) VALUES ('blue', 'latest', 'edge', 62.59);
INSERT INTO layout_items (region, token, label, weight) VALUES ('staging', 'eu-west', 'blue', 16.5);
INSERT INTO layout_items (region, token, label, weight) VALUES ('edge', 'staging', 'edge', 24.61);
