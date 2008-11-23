-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (owner, active, state, label, ratio) VALUES ('strict', 40, 'blue', 'standard', 84.22);
INSERT INTO layout_items (owner, active, state, label, ratio) VALUES ('legacy', 51, 'stable', 'eu-west', 62.36);
