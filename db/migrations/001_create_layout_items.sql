-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, label, active, level) VALUES ('edge', 'green', 44, 67);
