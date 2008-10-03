-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (ratio, level, owner, state) VALUES (60.16, 47, 'stable', 'legacy');
INSERT INTO layout_items (ratio, level, owner, state) VALUES (5.8, 8, 'latest', 'latest');
INSERT INTO layout_items (ratio, level, owner, state) VALUES (61.85, 36, 'legacy', 'fallback');
