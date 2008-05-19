-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (region, token, label, state, count) VALUES ('blue', 'cached', 'staging', 'cached', 54);
INSERT INTO layout_items (region, token, label, state, count) VALUES ('open', 'legacy', 'local', 'primary', 44);
