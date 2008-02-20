-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, token, region) VALUES (1, 'eu-west', 'primary');
INSERT INTO layout_items (active, token, region) VALUES (43, 'staging', 'cached');
INSERT INTO layout_items (active, token, region) VALUES (39, 'stable', 'cached');
