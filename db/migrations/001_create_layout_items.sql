-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, owner) VALUES (73, 'latest');
INSERT INTO layout_items (level, owner) VALUES (22, 'cached');
INSERT INTO layout_items (level, owner) VALUES (20, 'fallback');
