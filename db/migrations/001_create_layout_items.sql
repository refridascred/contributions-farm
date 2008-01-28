-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (state, label, owner, active) VALUES ('primary', 'blue', 'green', 61);
INSERT INTO layout_items (state, label, owner, active) VALUES ('staging', 'primary', 'primary', 15);
INSERT INTO layout_items (state, label, owner, active) VALUES ('latest', 'primary', 'strict', 33);
