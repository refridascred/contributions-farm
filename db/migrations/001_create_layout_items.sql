-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, state, ratio) VALUES ('stable', 'open', 54.54);
INSERT INTO layout_items (label, state, ratio) VALUES ('cached', 'stable', 83.78);
INSERT INTO layout_items (label, state, ratio) VALUES ('staging', 'eu-west', 65.12);
