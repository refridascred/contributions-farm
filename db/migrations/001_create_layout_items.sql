-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, count, state, ratio) VALUES ('edge', 66, 'eu-west', 4.26);
INSERT INTO layout_items (label, count, state, ratio) VALUES ('cached', 96, 'standard', 92.39);
