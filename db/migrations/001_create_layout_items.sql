-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    weight REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (state, level, weight, label, active) VALUES ('standard', 58, 52.43, 'staging', 17);
INSERT INTO layout_items (state, level, weight, label, active) VALUES ('cached', 17, 21.83, 'eu-west', 4);
