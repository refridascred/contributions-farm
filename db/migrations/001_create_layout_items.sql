-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (label, token, ratio, state) VALUES ('eu-west', 'cached', 88.12, 'staging');
INSERT INTO layout_items (label, token, ratio, state) VALUES ('edge', 'edge', 64.16, 'legacy');
