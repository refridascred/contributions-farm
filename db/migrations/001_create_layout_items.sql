-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (label, level, token) VALUES ('local', 21, 'strict');
INSERT INTO layout_items (label, level, token) VALUES ('blue', 18, 'local');
INSERT INTO layout_items (label, level, token) VALUES ('eu-west', 37, 'local');
