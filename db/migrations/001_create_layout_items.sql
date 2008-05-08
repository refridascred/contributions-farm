-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, label, owner, token) VALUES (48.77, 'primary', 'fallback', 'local');
INSERT INTO layout_items (ratio, label, owner, token) VALUES (40.65, 'stable', 'legacy', 'primary');
INSERT INTO layout_items (ratio, label, owner, token) VALUES (91.0, 'strict', 'legacy', 'fallback');
