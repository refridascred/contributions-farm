-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (region, label, active, state, count) VALUES ('legacy', 'eu-west', 70, 'strict', 56);
INSERT INTO layout_items (region, label, active, state, count) VALUES ('legacy', 'local', 32, 'staging', 78);
