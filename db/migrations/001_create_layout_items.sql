-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (token, owner, label, state) VALUES ('edge', 'edge', 'stable', 'blue');
INSERT INTO layout_items (token, owner, label, state) VALUES ('eu-west', 'fallback', 'cached', 'blue');
INSERT INTO layout_items (token, owner, label, state) VALUES ('open', 'legacy', 'cached', 'legacy');
