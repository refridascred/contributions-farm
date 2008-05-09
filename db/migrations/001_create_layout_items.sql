-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, token, active) VALUES ('latest', 'green', 81);
INSERT INTO layout_items (label, token, active) VALUES ('edge', 'legacy', 74);
INSERT INTO layout_items (label, token, active) VALUES ('strict', 'cached', 40);
