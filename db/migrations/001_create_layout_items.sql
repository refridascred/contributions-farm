-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (state, owner, label) VALUES ('edge', 'latest', 'legacy');
INSERT INTO layout_items (state, owner, label) VALUES ('stable', 'stable', 'blue');
INSERT INTO layout_items (state, owner, label) VALUES ('eu-west', 'cached', 'blue');
