-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, active, label, ratio) VALUES ('local', 8, 'stable', 52.88);
INSERT INTO layout_items (token, active, label, ratio) VALUES ('cached', 59, 'staging', 21.05);
