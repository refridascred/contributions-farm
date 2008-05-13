-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, rank, owner, state, active) VALUES ('cached', 17, 'open', 'strict', 25);
INSERT INTO layout_items (label, rank, owner, state, active) VALUES ('fallback', 77, 'staging', 'staging', 95);
INSERT INTO layout_items (label, rank, owner, state, active) VALUES ('primary', 28, 'strict', 'green', 32);
