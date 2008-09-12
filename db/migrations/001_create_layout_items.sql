-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (level, ratio, owner) VALUES (85, 63.01, 'blue');
INSERT INTO layout_items (level, ratio, owner) VALUES (24, 11.11, 'open');
INSERT INTO layout_items (level, ratio, owner) VALUES (68, 68.05, 'primary');
