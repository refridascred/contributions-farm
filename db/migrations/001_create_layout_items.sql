-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, ratio, state, owner, active) VALUES ('standard', 3.38, 'legacy', 'standard', 20);
INSERT INTO layout_items (label, ratio, state, owner, active) VALUES ('standard', 14.53, 'cached', 'eu-west', 96);
