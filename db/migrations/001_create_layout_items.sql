-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (owner, level, label) VALUES ('fallback', 47, 'primary');
INSERT INTO layout_items (owner, level, label) VALUES ('eu-west', 87, 'primary');
INSERT INTO layout_items (owner, level, label) VALUES ('eu-west', 11, 'latest');
