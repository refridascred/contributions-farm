-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (ratio, token, label, owner, state) VALUES (67.32, 'local', 'standard', 'blue', 'open');
INSERT INTO layout_items (ratio, token, label, owner, state) VALUES (39.5, 'stable', 'legacy', 'fallback', 'legacy');
INSERT INTO layout_items (ratio, token, label, owner, state) VALUES (9.17, 'blue', 'stable', 'stable', 'edge');
