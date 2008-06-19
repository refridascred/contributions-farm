-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, label, count, token, owner) VALUES ('edge', 'latest', 65, 'primary', 'green');
INSERT INTO layout_items (region, label, count, token, owner) VALUES ('edge', 'cached', 8, 'green', 'edge');
