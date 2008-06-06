-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, state, weight) VALUES ('eu-west', 'primary', 77.57);
INSERT INTO layout_items (label, state, weight) VALUES ('staging', 'latest', 80.64);
