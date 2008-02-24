-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, owner, ratio) VALUES ('primary', 'local', 25.39);
INSERT INTO layout_items (label, owner, ratio) VALUES ('standard', 'eu-west', 32.22);
INSERT INTO layout_items (label, owner, ratio) VALUES ('strict', 'stable', 18.28);
