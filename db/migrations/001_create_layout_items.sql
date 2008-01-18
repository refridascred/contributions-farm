-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (state, label, token, ratio) VALUES ('staging', 'local', 'cached', 2.97);
INSERT INTO layout_items (state, label, token, ratio) VALUES ('standard', 'local', 'blue', 0.33);
