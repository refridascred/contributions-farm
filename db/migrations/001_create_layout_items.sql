-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (label, active, region) VALUES ('fallback', 73, 'staging');
INSERT INTO layout_items (label, active, region) VALUES ('eu-west', 54, 'open');
INSERT INTO layout_items (label, active, region) VALUES ('local', 6, 'staging');
