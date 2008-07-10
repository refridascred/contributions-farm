-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, owner, score, state) VALUES (39, 'fallback', 96.84, 'open');
INSERT INTO layout_items (level, owner, score, state) VALUES (96, 'local', 8.36, 'cached');
