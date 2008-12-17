-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (ratio, active, token, level) VALUES (41.55, 13, 'stable', 56);
INSERT INTO layout_items (ratio, active, token, level) VALUES (79.4, 19, 'edge', 29);
INSERT INTO layout_items (ratio, active, token, level) VALUES (53.52, 95, 'open', 27);
